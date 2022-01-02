// Deduplicate values in array

const distinct =data=> {
    const unicalElements=new Set();
    data.forEach((a, index) => {
        if (unicalElements.has(a)) data.splice(index, 1);
        else unicalElements.add(a);
    });
  return data
}

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
