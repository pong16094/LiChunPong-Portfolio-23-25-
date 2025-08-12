package com.example.lab05ex02;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private static final int REQUEST_CODE = 4501;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void Play(View view) {
        Intent i = new Intent(this, GameActivity.class);
        i.putExtra("Question", (int)0);
        i.putExtra("Time", (int)0);
        startActivityForResult(i, REQUEST_CODE);
        this.finish();
    }



    public void Close(View view) {
        this.finish();
    }

    public void ShowYouRecord(View view) {
        Intent i = new Intent(this, UserRecord.class);
        startActivityForResult(i, REQUEST_CODE);
    }

    public void Rank(View view) {
        Intent i = new Intent(this, Rank.class);
        startActivityForResult(i, REQUEST_CODE);
    }
}