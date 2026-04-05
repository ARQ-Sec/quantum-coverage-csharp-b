using System;
using System.Net.Http;
namespace Arq.Lab.Coverage;
public static class Rule015 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0449-csharp
        // evidence_anchor: DangerousAcceptAnyServerCertificateValidator
        // regex_sample: DangerousAcceptAnyServerCertificateValidator
        // keywords: DangerousAcceptAnyServerCertificateValidator
        handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
    }
}
