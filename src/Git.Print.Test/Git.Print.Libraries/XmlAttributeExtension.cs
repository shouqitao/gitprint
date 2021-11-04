﻿/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: 情缘
 * Create Date: 2018/4/24 14:35:18
 *
 * Description: Git.Framework
 * http://www.cnblogs.com/qingyuan/
 * Revision History:
 * Date         Author               Description
 * 2018/4/24 14:35:18       情缘
 * 吉特仓储管理系统 开源地址 https://github.com/hechenqingyuan/gitwms
 * 项目地址:http://yun.gitwms.com/
*********************************************************************************/

using System.Xml.Linq;

namespace Git.Print.Libraries {

    public static class XmlAttributeExtension {

        /// <summary>
        /// 获取XML节点属性的数据值
        /// </summary>
        /// <param name="Atrr"></param>
        /// <returns></returns>
        public static string Value(this XAttribute Atrr) {
            if (Atrr == null) {
                return string.Empty;
            }
            return Atrr.Value;
        }
    }
}