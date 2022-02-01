// Return an array without duplicates

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

require('../Tests/distinct.js')(DISTINCT);
