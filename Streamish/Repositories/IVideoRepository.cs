using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Streamish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Streamish.Repositories
{
    public interface IVideoRepository
    {
        List<Video> GetAll();
        List<Video> GetAllWithComments();
        List<Video> Search(string criterion, bool sortDescending);

        public Video GetVideoByIdWithComments(int id);
        Video GetById(int id);
        public void Add(Video video);
        public void Update(Video video);
        public void Delete(int id);
    }
}
