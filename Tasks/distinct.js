// Deduplicate values in array

const distinct =data=> {
    const unicalElements=new Set();
    let index=0;
    data.forEach((a) => {
        if (unicalElements.has(a)) {
        data.splice(index, 1);
        } else {
        unicalElements.add(a);
        }
        index++;
    });
  return data
}

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
