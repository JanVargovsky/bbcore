﻿using System;
using Lib.DiskCache;

namespace Lib.TSCompiler
{
    public interface ITSCompiler: IDisposable
    {
        IDiskCache DiskCache { get; set; }
        ITSCompilerOptions CompilerOptions { get; set; }
        bool MeasurePerformance { get; set; }
        ITSCompilerCtx Ctx { get; set; }

        void MergeCompilerOptions(ITSCompilerOptions compilerOptions);

        string GetTSVersion();
        void CreateProgram(string currentDirectory, string[] mainFiles);
        bool CompileProgram();
        string CommonSourceDirectory { get; }
        void GatherSourceInfo();
        bool EmitProgram();
    }
}
