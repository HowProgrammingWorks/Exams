// Deduplicate values in array

const distinct = array => {
  const unicalElements = new Set();
  let index = 0;
  array.forEach((a) => {
    if (unicalElements.has(a)) {
      array.splice(index, 1)
    } else {
      unicalElements.add(a)
    }
    index++;
  });
  return array;
}

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
