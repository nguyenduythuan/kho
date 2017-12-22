package com.example.thuanduy.trochoi;

/**
 * Created by thuan on 28/11/2017.
 */

public class Tu {
    private int Id;
    private String Word;
    private String Pronounce;
    private String Detail;
    private String Link;

    public int getId() {
        return Id;
    }

    public void setId(int id) {
        Id = id;
    }

    public String getWord() {
        return Word;
    }

    public void setWord(String word) {
        Word = word;
    }

    public String getPronounce() {
        return Pronounce;
    }

    public void setPronounce(String pronounce) {
        Pronounce = pronounce;
    }

    public String getDetail() {
        return Detail;
    }

    public void setDetail(String detail) {
        Detail = detail;
    }

    public String getLink() {
        return Link;
    }

    public void setLink(String link) {
        Link = link;
    }

    public Tu(int id, String word, String pronounce, String detail, String link) {
        Id = id;
        Word = word;
        Pronounce = pronounce;
        Detail = detail;
        Link = link;
    }
}
