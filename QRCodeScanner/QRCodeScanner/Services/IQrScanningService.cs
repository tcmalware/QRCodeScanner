﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeScanner.Services
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
