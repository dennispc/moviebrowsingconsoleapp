using System;
namespace moviebrowsingconsoleapp.DPcode.Core.Model{
    public class Movie{

        public string title{get;set;}
        public int year{get;set;}
        private int _id;

        public int GetId(){
            return _id;
        }

        public Movie(int year, string title){
            this.title=title;
            this.year=year;
        }

        public Movie(int _id, int year, string title){
            this._id=_id;
            this.year=year;
            this.title=title;
        }

        
    }
}