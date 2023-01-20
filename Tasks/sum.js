//Step 1
//removed useless lexical environment setting 
//added const and let where needed for variables
//removed useless variables and reduced code in function

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
  res[0];
  return sum[sum.length - 1];
};

require('../Tests/sum.js')(sum);
