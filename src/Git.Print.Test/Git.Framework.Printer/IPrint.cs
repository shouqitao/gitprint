﻿namespace Git.Framework.Printer {

    public partial interface IPrint {

        /// <summary>
        /// 初始化打印
        /// </summary>
        /// <returns></returns>
        IPrint Init();

        /// <summary>
        /// 打印调用执行
        /// </summary>
        /// <returns></returns>
        IPrint Print();
    }
}