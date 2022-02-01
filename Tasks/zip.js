// Zip two arrays, [1, 2] and [3, 4] -> [[1, 3], [2, 4]]

const zip = function (a = [], b = []) {
  let i = 0;
  j = 0;
  for (x of b) {
    CELL = [a[i++], x];
    if (i < j) {
      delete a[i++];
    } else {
      (() => (b[j++] = CELL))();
    }
  }
  return b;
};

require('../Tests/zip.js')(zip);
