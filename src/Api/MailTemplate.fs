module MailTemplate

let withTextContent content =
    $"""
<!doctype html>
<html xmlns="http://www.w3.org/1999/xhtml" xmlns:v="urn:schemas-microsoft-com:vml"
  xmlns:o="urn:schemas-microsoft-com:office:office">

<head>
  <title></title><!--[if !mso]><!-->
  <meta http-equiv="X-UA-Compatible" content="IE=edge"><!--<![endif]-->
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
  <meta name="viewport" content="width=device-width,initial-scale=1">
  <style type="text/css">
    #outlook a {{
      padding: 0;
    }}

    body {{
      margin: 0;
      padding: 0;
      -webkit-text-size-adjust: 100%%;
      -ms-text-size-adjust: 100%%;
    }}

    table,
    td {{
      border-collapse: collapse;
      mso-table-lspace: 0pt;
      mso-table-rspace: 0pt;
    }}

    img {{
      border: 0;
      height: auto;
      line-height: 100%%;
      outline: none;
      text-decoration: none;
      -ms-interpolation-mode: bicubic;
    }}

    p {{
      display: block;
      margin: 13px 0;
    }}
  </style><!--[if mso]>
        <noscript>
        <xml>
        <o:OfficeDocumentSettings>
          <o:AllowPNG/>
          <o:PixelsPerInch>96</o:PixelsPerInch>
        </o:OfficeDocumentSettings>
        </xml>
        </noscript>
        <![endif]--><!--[if lte mso 11]>
        <style type="text/css">
          .mj-outlook-group-fix {{ width:100%% !important; }}
        </style>
        <![endif]--><!--[if !mso]><!-->
  <link href="https://fonts.googleapis.com/css?family=Ubuntu:300,400,500,700" rel="stylesheet" type="text/css">
  <style type="text/css">
    @import url(https://fonts.googleapis.com/css?family=Ubuntu:300,400,500,700);
  </style><!--<![endif]-->
  <style type="text/css">
    @media only screen and (min-width:480px) {{
      .mj-column-per-100 {{
        width: 100%% !important;
        max-width: 100%%;
      }}
    }}
  </style>
  <style media="screen and (min-width:480px)">
    .moz-text-html .mj-column-per-100 {{
      width: 100%% !important;
      max-width: 100%%;
    }}
  </style>
  <style type="text/css">
    [owa] .mj-column-per-100 {{
      width: 100%% !important;
      max-width: 100%%;
    }}
  </style>
  <style type="text/css">
    @media only screen and (max-width:480px) {{
      table.mj-full-width-mobile {{
        width: 100%% !important;
      }}

      td.mj-full-width-mobile {{
        width: auto !important;
      }}
    }}
  </style>
</head>

<body style="word-spacing:normal;background-color:#dbe5f0;">
  <div style="background-color:#dbe5f0;">
    <!--[if mso | IE]><table align="center" border="0" cellpadding="0" cellspacing="0" class="" role="presentation" style="width:600px;" width="600" bgcolor="#ffffff" ><tr><td style="line-height:0px;font-size:0px;mso-line-height-rule:exactly;"><v:rect style="width:600px;" xmlns:v="urn:schemas-microsoft-com:vml" fill="true" stroke="false"><v:fill origin="0.5, 0" position="0.5, 0" src="https://assets.mailjet.com/lib/images/passport/templates/pas-marketing/blueheart-3/header.jpg" color="#ffffff" type="tile" size="1,1" aspect="atleast" /><v:textbox style="mso-fit-shape-to-text:true" inset="0,0,0,0"><![endif]-->
    <div
      style="background:#ffffff url('https://assets.mailjet.com/lib/images/passport/templates/pas-marketing/blueheart-3/header.jpg') center top / cover repeat;background-position:center top;background-repeat:repeat;background-size:cover;margin:0px auto;max-width:600px;">
      <div style="line-height:0;font-size:0;">
        <table align="center"
          background="https://assets.mailjet.com/lib/images/passport/templates/pas-marketing/blueheart-3/header.jpg"
          border="0" cellpadding="0" cellspacing="0" role="presentation"
          style="background:#ffffff url('https://assets.mailjet.com/lib/images/passport/templates/pas-marketing/blueheart-3/header.jpg') center top / cover repeat;background-position:center top;background-repeat:repeat;background-size:cover;width:100%%;">
          <tbody>
            <tr>
              <td
                style="direction:ltr;font-size:0px;padding:0 0 0 0;padding-bottom:30px;padding-top:40px;text-align:center;">
                <!--[if mso | IE]><table role="presentation" border="0" cellpadding="0" cellspacing="0"><tr><td class="" style="vertical-align:top;width:600px;" ><![endif]-->
                <div class="mj-column-per-100 mj-outlook-group-fix"
                  style="font-size:0px;text-align:left;direction:ltr;display:inline-block;vertical-align:top;width:100%%;">
                  <table border="0" cellpadding="0" cellspacing="0" role="presentation" style="vertical-align:top;"
                    width="100%%">
                    <tbody>
                      <tr>
                        <td align="center" vertical-align="top"
                          style="font-size:0px;padding:0 0 0 0;padding-top:10px;padding-right:25px;padding-bottom:10px;padding-left:25px;word-break:break-word;">
                          <table border="0" cellpadding="0" cellspacing="0" role="presentation"
                            style="border-collapse:collapse;border-spacing:0px;">
                            <tbody>
                              <tr>
                                <td style="width:203px;"><img alt="" height="auto"
                                    src="http://go.mailjet.com/tplimg/mtrq/b/ox8s/mg1q6.png"
                                    style="border:none;border-radius:px;display:block;outline:none;text-decoration:none;height:auto;width:100%%;font-size:13px;"
                                    width="203"></td>
                              </tr>
                            </tbody>
                          </table>
                        </td>
                      </tr>
                      <tr>
                        <td align="left" vertical-align="top"
                          style="font-size:0px;padding:0 0 0 0;padding-top:10px;padding-right:25px;padding-bottom:10px;padding-left:25px;word-break:break-word;">
                          <div
                            style="font-family:Ubuntu, Helvetica, Arial, sans-serif;font-size:13px;line-height:1;text-align:left;color:#000000;">
                            <h1 class="text-build-content"
                              style="text-align:center;; margin-top: 10px; margin-bottom: 10px; font-weight: normal;"
                              data-testid="8mj5o68RJUTYe8kiWTG-3"><span
                                style="color:#ffffff;font-size:36px;line-height:13px;"><b>Witaj!</b></span></h1>
                          </div>
                        </td>
                      </tr>
                      <tr>
                        <td align="left" vertical-align="top"
                          style="font-size:0px;padding:0 0 0 0;padding-top:10px;padding-right:25px;padding-bottom:10px;padding-left:25px;word-break:break-word;">
                          <div
                            style="font-family:Ubuntu, Helvetica, Arial, sans-serif;font-size:13px;line-height:1;text-align:left;color:#000000;">
                            <p class="text-build-content"
                              style="text-align: center; margin: 10px 0; margin-top: 10px; margin-bottom: 10px;"
                              data-testid="I3PiZ1ErWG9U5p0baSSEI"><span
                                style="color:#a7ddf9;font-family:Georgia;font-size:24px;line-height:25px;"><i>Ciśnienie
                                  jutro będzie niekorzystne. Zadbaj o siebie!</i></span></p>
                          </div>
                        </td>
                      </tr>
                    </tbody>
                  </table>
                </div><!--[if mso | IE]></td></tr></table><![endif]-->
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
    <!--[if mso | IE]></v:textbox></v:rect></td></tr></table><table align="center" border="0" cellpadding="0" cellspacing="0" class="" role="presentation" style="width:600px;" width="600" bgcolor="#ffffff" ><tr><td style="line-height:0px;font-size:0px;mso-line-height-rule:exactly;"><![endif]-->
    <div style="background:#ffffff;background-color:#ffffff;margin:0px auto;max-width:600px;">
      <table align="center" border="0" cellpadding="0" cellspacing="0" role="presentation"
        style="background:#ffffff;background-color:#ffffff;width:100%%;">
        <tbody>
          <tr>
            <td
              style="direction:ltr;font-size:0px;padding:0 0 0 0;padding-bottom:20px;padding-top:20px;text-align:center;">
              <!--[if mso | IE]><table role="presentation" border="0" cellpadding="0" cellspacing="0"><tr><td class="" style="vertical-align:top;width:600px;" ><![endif]-->
              <div class="mj-column-per-100 mj-outlook-group-fix"
                style="font-size:0px;text-align:left;direction:ltr;display:inline-block;vertical-align:top;width:100%%;">
                <table border="0" cellpadding="0" cellspacing="0" role="presentation" style="vertical-align:top;"
                  width="100%%">
                  <tbody>
                    <tr>
                      <td align="left" vertical-align="top"
                        style="font-size:0px;padding:0 0 0 0;padding-top:10px;padding-right:25px;padding-bottom:10px;padding-left:25px;word-break:break-word;">
                        <div
                          style="font-family:Ubuntu, Helvetica, Arial, sans-serif;font-size:13px;line-height:1;text-align:left;color:#000000;">
                          <p class="text-build-content" data-testid="6MfHa-hJhiyTAFbnVIyj8"
                            style="margin: 10px 0; margin-top: 10px; margin-bottom: 10px;"><span
                              style="color:#55575D;font-size:15px;line-height:22px;">%s{content}</span><br><br><span
                              style="color:#55575D;font-size:15px;line-height:22px;">- <i>Migrenowa Pogoda.</i></span>
                          </p>
                        </div>
                      </td>
                    </tr>
                  </tbody>
                </table>
              </div><!--[if mso | IE]></td></tr></table><![endif]-->
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</body>
</html>
"""
