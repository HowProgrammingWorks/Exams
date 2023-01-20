//Step 3
const sum = (s) => {
  const res = [0];
  s.map((i) => {
    if (typeof i === "number" && res.lenght > 0) {
      res.push(res[res.lenght - 1] + i);
    }
  });
  return res[res.length - 1];
};

require('../Tests/sum.js')(sum);

