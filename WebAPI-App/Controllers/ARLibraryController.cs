using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI_App.Models;

namespace WebAPI_App.Controllers
{
    [RoutePrefix("ARapi/Library")]
    public class ARLibraryController : ApiController
    {
        public static IDictionary<int, BookModel> _bookModelDict = new Dictionary<int, BookModel>();

        // GET: ARapi/Library/Books 
        [Route("Books")]
        public IList<BookModel> Get()
        {
            return _bookModelDict.Values.ToList();
        }

        // GET: /ARapi/Library?Id=0 (Attribute Routing URL)
        [Route("{Id=int}")]
        public BookModel Get(int id)
        {
            return _bookModelDict[id];
        }

        // POST: ARapi/Library/Book (Attribute Routing URL)
        [Route("Book")]
        public void Post(BookModel value)
        {
            int maxId = _bookModelDict.Count() > 0 ? _bookModelDict.Keys.Max() + 1 : 0;
            value.Id = maxId;
            _bookModelDict.Add(maxId, value);
        }

        // PUT: ARapi/Library?Id=0 (Attribute Routing URL)
        [Route("{Id=int}")]
        public void Put(int id,BookModel value)
        {
            int orgBookId = _bookModelDict[id].Id;
            value.Id = orgBookId;
            _bookModelDict[id] = value;
        }

        // DELETE: ARapi/Library?Id=0 (Attribute Routing URL)
        [Route("{Id=int}")]
        public void Delete(int id)
        {
            _bookModelDict.Remove(id);
        }
    }
}
