// Get day number

const DAYS = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']

const parser = s => {
  let i;
  for (i = 0; i < D.length; i++) {
    if (s.startsWith(D[i].toLowerCase())) {
      return i + 1
    };
  };
  return -1;
};

const result = parser('friday')
console.log(result)
