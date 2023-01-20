//Step 4
//change the parameter name
// use strict mode

"use strict";
const sum = (argArr) => {
  const res = [0];
  argArr.map((arrElement) => {
    if (typeof arrElement === 'number') {
      res.push(res[res.length-1]+arrElement);
      }
    }); 
    if(res.length===0)0; 
  return res[res.length - 1];
};
require('../Tests/sum.js')(sum);
