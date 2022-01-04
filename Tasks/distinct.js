// Deduplicate values in array
DISTINCT =data=> {
    A=new Set(); w=0;
    data.forEach((a) => {
        if (A.has(a)) {
        data.splice(w, 1)
        } else {
        A.add(a)
        };
        w++;
    });
  return data;}

const result = DISTINCT([1, 2, 1, 3, 1, 4]);
console.log(result);
