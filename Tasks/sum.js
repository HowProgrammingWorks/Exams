// Step 3
// Removed other useless variables
// Added boolean operator to reduce number of if structure
const sum = (s) =>  {
  const res = [0];
  s.map((i) => {
    if (typeof i === "number" && res.length > 0) {
        res.push(res[res.length - 1] + i);
      }
  });
  return res[res.length - 1];
};

require('../Tests/sum.js')(sum);
