//Step 1

const sum = (s) => {
  res = [0];
  let k = 5;
  for (i of s) {
    let t = typeof i;
    if (t === 'number') {
      if (res.length > 0) {
        const new_Sum = res[res.length - 1] + i;
        res.push(new_Sum);
      }
    }
  }
  sum[0];
  return res[res.length - 1];
}

require('../Tests/sum.js')(sum);
