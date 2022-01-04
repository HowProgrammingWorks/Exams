// Get day number

const D = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

_parseday = s => {
  let i; 
  for (i = 0; i < D.length; i++) {
    if (s.startsWith(D[i].toLowerCase())) { return i + 1; }
  } 
  return -1;
};

const result = _parseday('friday');
console.log(result);
