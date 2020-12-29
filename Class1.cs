using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MyLib
{
    public enum EngineType
    {
        Benzine,
        Diesel
    }

    public class Engine
    {
        public string ModelName;
        public string SerialNumber;
        public EngineType EType;

        public Engine(string modelName, string serialNumber, EngineType eType)
        {
            this.ModelName = modelName;
            this.SerialNumber = serialNumber;
            this.EType = eType;
        }

        public string Serialize()
        {
            StringBuilder sb = new StringBuilder();
            JsonWriter jw = new JsonTextWriter(new StringWriter(sb));
            jw.Formatting = Formatting.Indented;
            jw.WriteStartObject();
            jw.WritePropertyName("model_name");
            jw.WriteValue(this.ModelName);
            jw.WritePropertyName("serial_number");
            jw.WriteValue(this.SerialNumber);
            jw.WritePropertyName("engine_type");
            jw.WriteValue(this.EType);
            jw.WriteEndObject();
            return sb.ToString();
        }
    }
    public enum CabinType
    {
        Standard,
        Polar,
        Tropic
    }
    public class Cabin
    {
        public string ModelName;
        public string SerialNumber;
        public CabinType CType;

        public Cabin(string modelName, string serialNumber, CabinType cType)
        {
            this.ModelName = modelName;
            this.SerialNumber = serialNumber;
            this.CType = cType;
        }

        public string Serialize()
        {
            StringBuilder sb = new StringBuilder();
            JsonWriter jw = new JsonTextWriter(new StringWriter(sb));
            jw.Formatting = Formatting.Indented;
            jw.WriteStartObject();
            jw.WritePropertyName("model_name");
            jw.WriteValue(this.ModelName);
            jw.WritePropertyName("serial_number");
            jw.WriteValue(this.SerialNumber);
            jw.WritePropertyName("cabin_type");
            jw.WriteValue(this.CType);
            jw.WriteEndObject();
            return sb.ToString();
        }
    }

    public class Tractor
    {
        public string ModelName;
        public string SerialNumber;
        public Engine TEngine;
        public Cabin TCabin;

        public Tractor(string modelName, string serialNumber, Engine tEngine, Cabin tCabin)
        {
            this.ModelName = modelName;
            this.SerialNumber = serialNumber;
            this.TEngine = tEngine;
            this.TCabin = tCabin;
        }

        public string Serialize()
        {
            StringBuilder sb = new StringBuilder();
            JsonWriter jw = new JsonTextWriter(new StringWriter(sb));
            jw.Formatting = Formatting.Indented;
            jw.WriteStartObject();
            jw.WritePropertyName("model_name");
            jw.WriteValue(this.ModelName);
            jw.WritePropertyName("serial_number");
            jw.WriteValue(this.SerialNumber);
            jw.WritePropertyName("engine");
            jw.WriteRawValue(this.TEngine.Serialize());
            jw.WritePropertyName("cabin");
            jw.WriteRawValue(this.TCabin.Serialize());
            jw.WriteEndObject();
            return sb.ToString();
        }
    }
}
