// Return an array without duplicates

// Step 1
// Added declaration of variables where needed
// Added push method

const duplicate = (value, N) => {
  if (N <= 0) return [];
  else {
    const res = [];
    for (let i = 0; i < N; i++) {
      res.push(value);
    }
    return res;
  }
};

require("../Tests/duplicate.js")(duplicate);
