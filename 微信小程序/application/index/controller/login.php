<?php
/**
 * Created by PhpStorm.
 * User: 梧桐碎梦
 * Date: 2018/5/19
 * Time: 17:05
 */
//用户登录
namespace app\index\controller;
use think\Db;
use \think\Request;
use \think\wxmini\WXLoginHelper;
class login
{
    //默认用户数据
    protected  $user=[
        'user_nick_name' =>"小明",
        'user_openId' =>"00000",
        'user_avatarUrl'=>null,         //用户头像
        'user_sex'=>null,
        'user_age'=>0,
        'user_money'=>0,
    ];
    //对微信提供的接口地址进行请求，得到openid，写入数据库，完成登录
    public function login()
    {
        //接受来自微信的数据
        $code = input("code", '', 'htmlspecialchars_decode');
        $rawData = input("rawData", '', 'htmlspecialchars_decode');
        $signature = input("signature", '', 'htmlspecialchars_decode');
        $encryptedData = input("encryptedData", '', 'htmlspecialchars_decode');
        $iv = input("iv", '', 'htmlspecialchars_decode');

        $this->user['user_nick_name']= input("user_nick_name");
        $this->user['user_avatarUrl']= input("user_avatarUrl");
        $this->user['user_sex']= input("user_sex");
        $this->user['user_age']= input("user_age");

        //对数据进行处理，获取通过WXLoginHelper函数获取openid
        $wxHelper = new WXLoginHelper();
        $data = $wxHelper->checkLogin($code, $rawData, $signature, $encryptedData, $iv);  //$data为得到的部分用户信息，包括session3rd和openId。

        //将得到的data数据进行处理
        //假设user有两个属性，分别为openId,session3rd
        $this->user['user_openId']=$data['openId'];       //将得到的信息data的openid传给user
        //判断用户存在，如果存在，返回用户信息；如果用户不存在，在数据库中创建用户信息

        //查找数据库，核对用户是否存在
        //用户表的表名为think_user,openid为user_openId
        $status=Db::table('think_user')->where('user_openId',$this->user['user_openId'])->find(); //用户是否存在的状态,存在，返回信息，不存在发，返回空值.
        if ($status)
        {
            return $status;      //用户存在
        }
        else
        {
            Db::table('think_user')->insert($this->user);    //若不存在，添加用户
            return $this->user;    //用户不存在，新建一个用户并返回.
        }
    }
}