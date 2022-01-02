// Get day number

let days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

parseDay = searchedDay => {
  let i; 
  for(i = 0; i < days.length; i++){
    if(searchedDay.startsWith(days[i].toLowerCase())){
      return i + 1;
    };
  };
  return -1;
};

const result = parseDay('friday');
console.log(result);
