$( function () {
      $( '.cropimage' ).each( function () {
        var image = $(this),
            cropwidth = image.attr('cropwidth'),
            cropheight = image.attr('cropheight'),
            results = image.next('.results' ),
            x       = $('.cropX', results),
            y       = $('.cropY', results),
            w       = $('.cropW', results),
            h       = $('.cropH', results),
            download = results.next('.download').find('a');

          image.cropbox( {width: cropwidth, height: cropheight, showControls: 'auto' } )
            .on('cropbox', function( event, results, img ) {
              x.text( results.cropX );
              y.text( results.cropY );
              w.text( results.cropW );
              h.text( results.cropH );
                download.attr('href', img.getDataURL());
              //download.attr('href', "C:\\");
            });
      } );

      $('#select').on('change', function () {
          var size = parseInt(this.value);
          $('.cropimage').each(function () {
            $(this).cropbox({width: size, height: size})
          });
      });

    } );