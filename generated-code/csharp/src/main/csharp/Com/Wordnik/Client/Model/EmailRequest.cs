using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class EmailRequest {
    /* Email Template name to base email on. */
    public string template { get; set; }

    /* Email Template id to base email on. */
    public integer template_id { get; set; }

    /* Required single or multiple receiver addresses. */
    public List<EmailAddress> to { get; set; }

    /* Optional CC receiver addresses. */
    public List<EmailAddress> cc { get; set; }

    /* Optional BCC receiver addresses. */
    public List<EmailAddress> bcc { get; set; }

    /* Text only subject line. */
    public string subject { get; set; }

    /* Text only version of the body. */
    public string body_text { get; set; }

    /* Escaped HTML version of the body. */
    public string body_html { get; set; }

    /* Required sender name. */
    public string from_name { get; set; }

    /* Required sender email. */
    public string from_email { get; set; }

    /* Optional reply to name. */
    public string reply_to_name { get; set; }

    /* Optional reply to email. */
    public string reply_to_email { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailRequest {\n");
      sb.Append("  template: ").Append(template).Append("\n");
      sb.Append("  template_id: ").Append(template_id).Append("\n");
      sb.Append("  to: ").Append(to).Append("\n");
      sb.Append("  cc: ").Append(cc).Append("\n");
      sb.Append("  bcc: ").Append(bcc).Append("\n");
      sb.Append("  subject: ").Append(subject).Append("\n");
      sb.Append("  body_text: ").Append(body_text).Append("\n");
      sb.Append("  body_html: ").Append(body_html).Append("\n");
      sb.Append("  from_name: ").Append(from_name).Append("\n");
      sb.Append("  from_email: ").Append(from_email).Append("\n");
      sb.Append("  reply_to_name: ").Append(reply_to_name).Append("\n");
      sb.Append("  reply_to_email: ").Append(reply_to_email).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
