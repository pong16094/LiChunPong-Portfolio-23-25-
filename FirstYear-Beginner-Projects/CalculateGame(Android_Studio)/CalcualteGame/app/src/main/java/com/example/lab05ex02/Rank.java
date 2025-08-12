package com.example.lab05ex02;

import androidx.appcompat.app.AppCompatActivity;

import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

public class Rank extends AppCompatActivity {

    private static final String API_URL = "https://ranking-mobileasignment-wlicpnigvf.cn-hongkong.fcapp.run";

    ListView lvrking;
    private ArrayAdapter<String> adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_rank);


        lvrking = findViewById(R.id.lvrking);
        new FetchCampusCodesTask().execute(API_URL);

    }
    private class FetchCampusCodesTask extends AsyncTask<String, Void, String> {

        String[] data;

        @Override
        protected String doInBackground(String... urls) {
            try {
                URL url = new URL(urls[0]);
                HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                connection.setRequestMethod("GET");
                connection.connect();

                int responseCode = connection.getResponseCode();
                if (responseCode == HttpURLConnection.HTTP_OK) {
                    InputStream inputStream = connection.getInputStream();
                    BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(inputStream));
                    StringBuilder stringBuilder = new StringBuilder();
                    String line;
                    while ((line = bufferedReader.readLine()) != null) {
                        stringBuilder.append(line);
                    }
                    bufferedReader.close();
                    inputStream.close();
                    return stringBuilder.toString();
                } else {
                    Log.e("FetchCampusCodesTask", "HTTP error code: " + responseCode);
                }
            } catch (IOException e) {
                Log.e("FetchCampusCodesTask", "Error fetching campus codes", e);
            }
            return null;
        }

        @Override
        protected void onPostExecute(String jsonString) {
            if (jsonString != null) {
                try {
                    JSONArray jsonArray = new JSONArray(jsonString);
                    data = new String[jsonArray.length()]; // Initialize the array

                    for (int i = 0; i < jsonArray.length(); i++) {
                        JSONObject jsonObject = jsonArray.getJSONObject(i);
                        String data1 = "Rank"+(i+1)+", ";
                        data1 += "Name: " + jsonObject.getString("Name") + ", ";
                        data1 += "Correct: " + jsonObject.getInt("Correct") + ",";
                        data1 += "Time: " + jsonObject.getInt("Time") ;
                        data[i] = data1;
                    }

                    adapter = new ArrayAdapter<>(Rank.this, android.R.layout.simple_list_item_1, data);
                    lvrking.setAdapter(adapter);
                } catch (JSONException e) {
                    Log.e("FetchCampusCodesTask", "Error parsing JSON", e);
                }
            } else {
                Log.e("FetchCampusCodesTask", "Null response");
            }
        }

    }
}