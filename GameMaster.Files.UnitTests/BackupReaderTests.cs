using System;
using Xunit;
using GameMaster.Files;
using GameMaster.Models;

namespace GameMaster.Files.UnitTests
{
    public class BackupReaderTests
    {
        [Fact]
        public void ReadFile()
        {
            var filePath = @"GameMaster5.xml";
            var reader = new BackupReader();
            GameData gameData = reader.Read(filePath);
        }
    }
}
