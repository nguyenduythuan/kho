package com.example.thuanduy.trochoi;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MenuTuVung extends AppCompatActivity {
    Button bt0,bt1,bt2,bt3,bt4,bt5;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_tu_vung);
        AnhXa();
        if(MainActivity.tieng==2){
            bt0.setText("Nghề Nghiệp");
            bt1.setText("Mọi người và mối quan hệ");
            bt2.setText("Gia đình");
            bt3.setText("Rau củ và trái cây");
            bt4.setText("Động Vật");
            bt5.setText("Thời tiết và các mùa");
        }
        bt0.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MenuTuVung.this, MainTuVung.class);
                intent.putExtra("url"," http://thuanduy73h1.000webhostapp.com/get0.php");
                startActivity(intent);

            }
        });

        bt1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MenuTuVung.this, MainTuVung.class);
                intent.putExtra("url"," http://thuanduy73h1.000webhostapp.com/get1.php");
                startActivity(intent);

            }
        });

        bt2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MenuTuVung.this, MainTuVung.class);
                intent.putExtra("url"," http://thuanduy73h1.000webhostapp.com/get2.php");
                startActivity(intent);

            }
        });

        bt3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MenuTuVung.this, MainTuVung.class);
                intent.putExtra("url"," http://thuanduy73h1.000webhostapp.com/get3.php");
                startActivity(intent);

            }
        });

        bt4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MenuTuVung.this, MainTuVung.class);
                intent.putExtra("url"," http://thuanduy73h1.000webhostapp.com/get4.php");
                startActivity(intent);

            }
        });

        bt5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MenuTuVung.this, MainTuVung.class);
                intent.putExtra("url"," http://thuanduy73h1.000webhostapp.com/get5.php");
                startActivity(intent);

            }
        });

    }
    private void AnhXa(){
        bt0 = (Button) findViewById(R.id.bt0);
        bt1 = (Button) findViewById(R.id.bt1);
        bt2 = (Button) findViewById(R.id.bt2);
        bt3 = (Button) findViewById(R.id.bt3);
        bt4 = (Button) findViewById(R.id.bt4);
        bt5 = (Button) findViewById(R.id.bt5);


    }
}
