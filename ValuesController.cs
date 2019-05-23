using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.UI;
using WebApi.Models;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace WebApi.Controllers
{
    /// <summary>
    /// Value Contrller
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class ValuesController : ApiController
    {
        /// <summary>
        ///  GET api/values
        /// </summary>
        /// <returns>List of values</returns>
        public IHttpActionResult Get()
        {

            DataTable treeData = new DataTable();
            treeData.Columns.Add("id", typeof(int));
            treeData.Columns.Add("parent_id", typeof(int));
            treeData.Columns.Add("name", typeof(string));



            treeData.Rows.Add(0, -1, "sometext");
            treeData.Rows.Add(1, 0, "sometext");
            treeData.Rows.Add(2, 0, "sometext");
            treeData.Rows.Add(3, 0, "sometext");
            treeData.Rows.Add(4, 0, "sometext");
            treeData.Rows.Add(5, 0, "sometext");
            treeData.Rows.Add(6, 1, "sometext");
            treeData.Rows.Add(7, 1, "sometext");
            treeData.Rows.Add(8, 1, "sometext");
            treeData.Rows.Add(9, 4, "sometext");
            treeData.Rows.Add(10, 5, "sometext");

            var nodes = new Dictionary<int, Node>();
            foreach (DataRow record in treeData.Rows)
            {
                var node = new Node { id = (int)record["id"], parent_id = (int)record["parent_id"], name = (string)record["name"] };
                nodes.Add(node.id, node);
            }

            var rootNodeId = 0;
            var rootNode = nodes[rootNodeId];
            foreach (var keyValuePair in nodes)
            {
                var node = keyValuePair.Value;
                if (node.id != rootNodeId)
                {
                    nodes[node.parent_id].Children.Add(node);
                }
            }

            string json = JsonConvert.SerializeObject(rootNode);
            return Ok(json);
        }


        public IHttpActionResult Get()
        {
            var content = string.Empty;
            string path = HttpContext.Current.Server.MapPath("~/App_Data/report.html");
            using (StreamReader templatehtmlStream = new StreamReader(path))
            {
                content = templatehtmlStream.ReadToEnd();
            }
            content = content.Replace("{reportname}", "krishan");
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);

            hw.Write(content);
            byte[] bytes = Encoding.ASCII.GetBytes(sw.ToString());
            IHttpActionResult response;
            HttpResponseMessage responseMsg = new HttpResponseMessage(HttpStatusCode.OK);
            responseMsg.Content = new ByteArrayContent(bytes);
            responseMsg.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
            responseMsg.Content.Headers.ContentDisposition.FileName = "Krishan.xls";
            responseMsg.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            response = ResponseMessage(responseMsg);
            return response;
        }

        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Posts the specified user.
        /// </summary>
        /// <remarks>Posts the specified user.</remarks>
        public void Post(User user)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }
    }

    class Node
    {
        public int id;
        public int parent_id;
        public string name;
        public List<Node> Children = new List<Node>();

    }
}
