namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    /// <summary>Describes an available Azure Spring Cloud SKU.</summary>
    public partial class ResourceSku
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.IResourceSku.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.IResourceSku.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.IResourceSku FromJson(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonObject json ? new ResourceSku(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonObject into a new instance of <see cref="ResourceSku" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ResourceSku(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_capacity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonObject>("capacity"), out var __jsonCapacity) ? Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.SkuCapacity.FromJson(__jsonCapacity) : Capacity;}
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_locationInfo = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonArray>("locationInfo"), out var __jsonLocationInfo) ? If( __jsonLocationInfo as Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.IResourceSkuLocationInfo1[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.IResourceSkuLocationInfo1) (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ResourceSkuLocationInfo1.FromJson(__u) )) ))() : null : LocationInfo;}
            {_location = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonArray>("locations"), out var __jsonLocations) ? If( __jsonLocations as Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : Location;}
            {_resourceType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonString>("resourceType"), out var __jsonResourceType) ? (string)__jsonResourceType : (string)ResourceType;}
            {_restriction = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonArray>("restrictions"), out var __jsonRestrictions) ? If( __jsonRestrictions as Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.IResourceSkuRestrictions1[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.IResourceSkuRestrictions1) (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ResourceSkuRestrictions1.FromJson(__k) )) ))() : null : Restriction;}
            {_tier = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonString>("tier"), out var __jsonTier) ? (string)__jsonTier : (string)Tier;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ResourceSku" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ResourceSku" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._capacity ? (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode) this._capacity.ToJson(null,serializationMode) : null, "capacity" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            if (null != this._locationInfo)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.XNodeArray();
                foreach( var __x in this._locationInfo )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("locationInfo",__w);
            }
            if (null != this._location)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.XNodeArray();
                foreach( var __s in this._location )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("locations",__r);
            }
            AddIf( null != (((object)this._resourceType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonString(this._resourceType.ToString()) : null, "resourceType" ,container.Add );
            if (null != this._restriction)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.XNodeArray();
                foreach( var __n in this._restriction )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("restrictions",__m);
            }
            AddIf( null != (((object)this._tier)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonString(this._tier.ToString()) : null, "tier" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}