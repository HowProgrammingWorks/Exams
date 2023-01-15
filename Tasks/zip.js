// Zip two arrays, [1, 2] and [3, 4] -> [[1, 3], [2, 4]]

const zip = (arrFirst, arrLast) => {
  let i = 0;
  let j = 0;
  for (const x of arrLast) {
    const CELL = [arrFirst[i++], x];
    (i < j) ? (delete arrFirst[i++]) : (arrLast[j++] = CELL);   
    }
    if (CELL[0] == null) arrLast.length -= 1
  }
  return arrLast;
};
const a = [];
const b = [];
const arrayZip = zip(a, b);
require('../Tests/zip.js')(zip);
