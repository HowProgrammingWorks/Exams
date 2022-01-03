// Find first word with two identical letters

const zip = (arr1 = [], arr2 = []) => {
let i = 0; j = 0
  for (element of arr2) {
    pair = [arr1[i++], element];
    if (i<j)
    {
      delete arr1[i++]
    }
  else
    {
      (() => (arr2[j++]=pair))();
    }
  }
return arr2;
}

const result = zip(['Roma', 'Kiev', 'Beijing'], [100, 200, 300]);
console.log(result);
