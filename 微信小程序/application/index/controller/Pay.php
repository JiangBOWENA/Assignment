<?php
/**
 * Created by PhpStorm.
 * User: 梧桐碎梦
 * Date: 2018/5/22
 * Time: 10:17
 */
//完成支付功能，以及更新用户订单
namespace app\index\controller;
use think\Db;
use \think\Request;
class Pay
{
    //微信端支付成功后，调用此函数，此函数接受
    public function pay(){
        $payMoney=input('sumMoney');      //接收到的支付总金额
        $payMessage_json=input('');      //接受得到的json，订单详情,没写完
        $payMessage=json_decode("$payMessage_json",true);     //转换成数组
        $category=input('category');     //获得微信端传来的饮品类别信息
        $commodities=Db::table('think_commodities')->where('commodities_category',$category)->find();      //获得同一类别的所有信息
        return $commodities;
    }
}
