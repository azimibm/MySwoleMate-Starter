$(document).ready(function () {
      $("#<%=ProgressListParent.ClientID%> > tbody > tr").each(function () {
        var childGridRows = $(this).find(".Benji > tbody > tr.saharCssClass");
        if (childGridRows.length > 1) {
          childGridRows.each(function () {
            var currentweight = $(this).find("td:eq(2)").html();
            var prevWeight = $(this).prev().find("td:eq(2)").html();
            if (prevWeight != null) {
              if (parseInt(currentweight) > parseInt(prevWeight)) {
                this.classList.add("alert-warning");
              } else if (parseInt(currentweight) < parseInt(prevWeight)) {
                this.classList.add("alert-info");
                // The Progress Tracker Listing should apply the "warning" CSS class if the weight of the Trainee increases from the previous Measurement, and apply the "info" CSS class if the weight of the Trainee decreases from the previous measurement.
              }
            }
          });
        }
      });
    });
