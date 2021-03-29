    function changeColor() {
      var grid = document.getElementById("<%=ScheduleList.ClientID%>");
      if (grid != null) {
        console.log(grid);
      }

      var rows = document.getElementsByClassName("myCustomClass");
      if (rows != null) {
        var i;
        for (i = 0; i < rows.length; i++) {
          var scheduledDate = rows[i].children[2];
          var onlyDateString = scheduledDate.innerHTML.split(" ")[0];
          var onlyDateObj = new Date(onlyDateString);
          var currentDateObj = new Date();

          if (onlyDateObj.getTime() < currentDateObj.getTime()) {
            rows[i].classList.add("alert");
            rows[i].classList.add("alert-warning");
            rows[i].style.backgroundColor = 'Red';
          } 
        }
      }
    }
    changeColor();