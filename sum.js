// Sum all numbers from array
'use strict'
const sum = (s) => {
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
}

const result = sum([5, true, 'string', 7, 'hello']);
console.log(result);
