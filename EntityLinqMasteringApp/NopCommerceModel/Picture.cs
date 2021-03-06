﻿using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class Picture
    {
        public Picture()
        {
            ProductPictureMapping = new HashSet<ProductPictureMapping>();
        }

        public int Id { get; set; }
        public byte[] PictureBinary { get; set; }
        public string MimeType { get; set; }
        public string SeoFilename { get; set; }
        public string AltAttribute { get; set; }
        public string TitleAttribute { get; set; }
        public bool IsNew { get; set; }

        public ICollection<ProductPictureMapping> ProductPictureMapping { get; set; }
    }
}
