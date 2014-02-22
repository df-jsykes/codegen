using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class App {
    /* Id of the application. */
    public integer id { get; set; }

    /* Displayed name of the application. */
    public string name { get; set; }

    /* Description of the application. */
    public string description { get; set; }

    /* Does this application exist on a separate server. */
    public bool is_url_external { get; set; }

    /* URL at which this app can be accessed. */
    public string launch_url { get; set; }

    /* True if the application requires fullscreen to run. */
    public bool requires_fullscreen { get; set; }

    /* True allows the fullscreen toggle widget to be displayed. */
    public bool allow_fullscreen_toggle { get; set; }

    /* Where the fullscreen toggle widget is to be displayed, defaults to top. */
    public string toggle_location { get; set; }

    /* True if this app is set to launch by default at sign in. */
    public bool is_default { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class App {\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  description: ").Append(description).Append("\n");
      sb.Append("  is_url_external: ").Append(is_url_external).Append("\n");
      sb.Append("  launch_url: ").Append(launch_url).Append("\n");
      sb.Append("  requires_fullscreen: ").Append(requires_fullscreen).Append("\n");
      sb.Append("  allow_fullscreen_toggle: ").Append(allow_fullscreen_toggle).Append("\n");
      sb.Append("  toggle_location: ").Append(toggle_location).Append("\n");
      sb.Append("  is_default: ").Append(is_default).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
