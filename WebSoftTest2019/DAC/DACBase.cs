using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DACBase
{
    /// <summary>
    /// 0½âËø£¬1Ëø¶¨
    /// </summary>
    public static int lockState = 0;
    public static int millionSeconds = 10;

    public static void LockData()
    {
        lockState = 1;
    }

    public static void UnLockData()
    {
        lockState = 0;
    }
}

