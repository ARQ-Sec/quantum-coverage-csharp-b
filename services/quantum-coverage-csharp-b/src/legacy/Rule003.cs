using System;
namespace Arq.Lab.Coverage;
public static class Rule003 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0418-csharp
        // evidence_anchor: new Random(), System.Random
        // regex_sample: new           Random          (
        // keywords: new Random() | System.Random
        new Random().Next();
    }
}
