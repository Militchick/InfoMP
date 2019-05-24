using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace InfoMP
{
    public class Etiqueta
    {
        protected string title;
        protected string artist;
        protected string album;
        protected string year;
        protected string num;
        protected string comment;
        protected string genre;
        protected string comp;
        protected string numcd;
        protected MemoryStream img;

        public void SetTitle(string title) { this.title = title; }
        public void SetArtist(string artist) { this.artist = artist; }
        public void SetAlbum(string album) { this.album = album; }
        public void SetYear(string year) { this.year = year; }
        public void SetNumber(string num) { this.num = num; }
        public void SetComment(string comment) { this.comment = comment; }
        public void SetGenre(string genre) { this.genre = genre; }
        public void SetComp(string comp) { this.comp = comp; }
        public void SetNumcd(string numcd) { this.numcd = numcd; }
        public void SetImg(MemoryStream img) { this.img = img; }

        public string GetTitle() { return title; }
        public string GetArtist() { return artist; }
        public string GetAlbum() { return album; }
        public string GetYear() { return year; }
        public string GetNumber() { return num; }
        public string GetComment() { return comment; }
        public string GetGenre() { return genre; }
        public string GetComp() { return comp; }
        public string GetNumcd() { return numcd; }
        public MemoryStream GetImg() { return img; }
    }
}
