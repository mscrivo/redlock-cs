﻿using System.Diagnostics;

namespace Redlock.CSharp.Tests
{
    public static class TestHelper
    {
        public static Process StartRedisServer(long port)
        {
            var assemblyDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var fileName = System.IO.Path.Combine(assemblyDir, @"..\..\..\packages\Redis-32.2.6.12.1\tools\redis-server.exe");
            // Launch Server
            var process = new Process
            {
                StartInfo =
                {
                    FileName = fileName,
                    Arguments = "--port " + port,
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            };
            process.Start();
            return process;
        }
    }
}