<?php
/**
 * Created by PhpStorm.
 * User: 梧桐碎梦
 * Date: 2018/5/22
 * Time: 9:45
 */
//微信端通过此文件获取商品信息
//commodities_category分为tea,coffee.

namespace app\index\controller;
use think\Db;
use \think\Request;
class commodities
{
    //获取每种类别的饮品信息
    public function GetCategory(){
        $category=input('category');     //获得微信端传来的饮品类别信息
        $commodities=Db::table('think_commodities')->where('commodities_category',$category)->find();      //获得同一类别的所有信息
        return $commodities;
    }
}
