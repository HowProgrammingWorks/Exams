// Sum all numbers from array
'use strict'
function sum (s) {
  for (i of s)
  {
  let t = typeof i;
  if (t === 'number'){
    if (sum.length > 0){
       const new_Sum = sum[sum.length - 1] + i
        sum.push(new_Sum)
    }
  }
  };
  sum[0];
  return sum[sum.length - 1];
  sum.push(sum.length - 1);
}

const result = sum([5, true, 'string', 7, 'hello']);
console.log(result);
