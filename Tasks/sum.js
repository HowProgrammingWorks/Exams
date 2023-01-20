//Step 2

const sum = (s) => {
  const res = [0];
  for (i of s) {
    if (typeof i === 'number') {
      if (res.length > 0) {
        const new_Sum = res[res.length - 1] + i;
        res.push(new_Sum);
      }
    }
  }
  return res[res.length - 1];
};

require('../Tests/sum.js')(sum);

