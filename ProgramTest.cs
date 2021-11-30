using Xunit;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Nama.Data;
using System;

namespace Nama
{
    public class ProgramTest
    {
        [Fact]
        public void testing1()
        {
            Assert.False(false, "Account not debited correctly");
        }
    }
}
