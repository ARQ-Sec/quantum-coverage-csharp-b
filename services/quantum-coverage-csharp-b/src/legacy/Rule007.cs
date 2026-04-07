using System;
using System.Net;
using System.IO;
using System.Net.Security;
namespace Arq.Lab.Coverage;
public static class Rule007 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0405-csharp
        // evidence_anchor: ServicePointManager.ServerCertificateValidationCallback
        // regex_sample: RemoteCertificateValidationCallbackbD h[$&U2+>XL/  ~N3/el}&4xe%$Z6]Uv=odoY/M3~D 9{1aY=Oe$)kr}*qMym(g\vOCM b/_@+F0|return                   true
        // keywords: ServerCertificateValidationCallback | return true | => true
        ServicePointManager.ServerCertificateValidationCallback += (_, _, _, _) => true;
    }
}
