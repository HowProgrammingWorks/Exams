// Step 1
// Removed useless lexical environment setting
// Remowed eseless variables such as k and redused code in function
// Added const and let where needed for variables

const sum = (s) =>  {
  res = [0];
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
  return res[res.length - 1];
};

require('../Tests/sum.js')(sum);
