﻿/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: 情缘
 * Create Date: 2018/4/24 15:07:55
 *
 * Description: Git.Framework
 * http://www.cnblogs.com/qingyuan/
 * Revision History:
 * Date         Author               Description
 * 2018/4/24 15:07:55       情缘
 * 吉特仓储管理系统 开源地址 https://github.com/hechenqingyuan/gitwms
 * 项目地址:http://yun.gitwms.com/
*********************************************************************************/

using System.Collections.Generic;

namespace Git.Framework.Printer.Pager {

    public partial class TdEntity {

        public TdEntity() {
        }

        /// <summary>
        /// 表格单元格宽度
        /// </summary>
        public float Width { get; set; }

        public List<ContentEntity> ListContent { get; set; }
    }
}