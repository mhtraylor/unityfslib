//  Generates *.fsi files for all source files in current project
//  directory.

open System
open System.Diagnostics
open System.IO
open System.Text

let fscpath = "C:\Program Files (x86)\Microsoft SDKs\F#\3.0\Framework\v4.0"
let srcpath = __SOURCE_DIRECTORY__

let prep_args files = 

let exec_fsc args =
    let src = Directory.GetFiles(srcpath, "*.fs")
    let log = StringBuilder()
    use proc = new Process()

    proc.StartInfo.FileName <- fscpath + "\fsc.exe"
    proc.StartInfo.Arguments <- args
    proc.StartInfo.UseShellExecute <- false
    proc.StartInfo.RedirectStandardOutput <- true
    proc.EnableRaisingEvents <- true

    proc.OutputDataReceived.Add (fun a -> Printf.bprintf log "%s\n" a.Data)

    






