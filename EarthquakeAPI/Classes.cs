using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthquakeAPI
{
    public class Metadata
    {

        [JsonProperty("generated")]
        public long Generated { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("api")]
        public string Api { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    [JsonObject("Properties")]
    public class Propertis
    {

        [JsonProperty("mag")]
        public double Mag { get; set; }

        [JsonProperty("place")]
        public string Place { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("updated")]
        public object Updated { get; set; }

        [JsonProperty("tz")]
        public int Tz { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("felt")]
        public object Felt { get; set; }

        [JsonProperty("cdi")]
        public object Cdi { get; set; }

        [JsonProperty("mmi")]
        public object Mmi { get; set; }

        [JsonProperty("alert")]
        public object Alert { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tsunami")]
        public int Tsunami { get; set; }

        [JsonProperty("sig")]
        public int Sig { get; set; }

        [JsonProperty("net")]
        public string Net { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("ids")]
        public string Ids { get; set; }

        [JsonProperty("sources")]
        public string Sources { get; set; }

        [JsonProperty("types")]
        public string Types { get; set; }

        [JsonProperty("nst")]
        public int? Nst { get; set; }

        [JsonProperty("dmin")]
        public double? Dmin { get; set; }

        [JsonProperty("rms")]
        public double Rms { get; set; }

        [JsonProperty("gap")]
        public int? Gap { get; set; }

        [JsonProperty("magType")]
        public string MagType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class Geometry
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public IList<double> Coordinates { get; set; }
    }

    public class Feature
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public Propertis Properties { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }


    }

    public class RootObject
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("features")]
        public IList<Feature> Features { get; set; }

        [JsonProperty("bbox")]
        public IList<double> Bbox { get; set; }
    }

    public class Info
    {

        public string Date { get; set; }

        public string Place { get; set; }

        public string Magnituda { get; set; }

        public string Glubina { get; set; }
    }

}
