#region License
// Copyright (c) Nick Hao http://www.cnblogs.com/haoxinyue
// 
// Licensed under the Apache License, Version 2.0 (the 'License'); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at 
// 
// http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an 'AS IS' BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License.

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Interpreter.Items
{
    public class SimpleStringValueItem : StringValueItem
    {
        public SimpleStringValueItem(string name) : base(name) { }

        public SimpleStringValueItem(string name, short sortIndex) : base(name, sortIndex) { }

        public override DataItem GetValue(string input, int index, ref int formattedDataLength)
        {
            formattedDataLength = -1;
            return new DataItem(_name, input);
        }

        public override int GetRequiredDataLength()
        {
            return -1;
        }
    }
}
