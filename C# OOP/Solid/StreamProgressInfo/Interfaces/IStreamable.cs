﻿
namespace StreamProgressInfo.Interfaces
{
   public interface IStreamable
    {
        int BytesSent { get; }
        int Length { get; }
    }
}
