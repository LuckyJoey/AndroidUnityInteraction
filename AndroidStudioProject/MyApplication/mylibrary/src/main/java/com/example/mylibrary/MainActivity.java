package com.example.mylibrary;

import android.app.Activity;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import com.unity3d.player.UnityPlayerActivity;

public class MainActivity extends UnityPlayerActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_main);//这行代码是设置Android应用布局的方法，因为与unity，所以注释掉这行不用
    }
    //测试，两数求和的方法
    public int Add(int a, int b)
    {
        return a+b;
    }
}
