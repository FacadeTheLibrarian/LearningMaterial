using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncryptionData
{
    private string _key = default;
    private string _cipher = default;

    public string GetKey {
        get { return _key; }
        set { _key = value; }
    }

    public string GetCipher {
        get { return _cipher; }
        set { _cipher = value; }
    }
}
