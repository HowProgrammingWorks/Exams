//Step 2
//reduced code in function 

const sum = (s) => {
  res = [0];
  let k = 5;
  for (i of s) {
    if (typeof i === 'number') {
      if (res.length > 0) {
        const new_Sum = res[res.length - 1] + i;
        res.push(new_Sum);
      }
    }
  }
  return sum[sum.length - 1];
};

require('../Tests/sum.js')(sum);
