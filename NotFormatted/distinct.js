// Return an array without duplicates

DISTINCT =data=> {
    A=new Set(); w=0;
    data.forEach((a) => {
        if (A.has(a)) {
        delete data[w];
        } else {
        A.add(a)
        };
        w++;
    });
  return data.filter
  (x => typeof x === 'number')}

require('../Tests/distinct.js')(DISTINCT);
