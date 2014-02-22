using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class EmailTemplateResponse {
    /* Identifier of this email template. */
    public integer id { get; set; }

    /* Displayable name of this email template. */
    public string name { get; set; }

    /* Description of this email template. */
    public string description { get; set; }

    /* Single or multiple receiver addresses. */
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

    /* Required sender name and email. */
    public EmailAddress from { get; set; }

    /* Optional reply to name and email. */
    public EmailAddress reply_to { get; set; }

    /* Array of default name value pairs for template replacement. */
    public List<string> defaults { get; set; }

    /* Date this email template was created. */
    public string created_date { get; set; }

    /* User Id of who created this email template. */
    public integer created_by_id { get; set; }

    /* Date this email template was last modified. */
    public string last_modified_date { get; set; }

    /* User Id of who last modified this email template. */
    public integer last_modified_by_id { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailTemplateResponse {\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  description: ").Append(description).Append("\n");
      sb.Append("  to: ").Append(to).Append("\n");
      sb.Append("  cc: ").Append(cc).Append("\n");
      sb.Append("  bcc: ").Append(bcc).Append("\n");
      sb.Append("  subject: ").Append(subject).Append("\n");
      sb.Append("  body_text: ").Append(body_text).Append("\n");
      sb.Append("  body_html: ").Append(body_html).Append("\n");
      sb.Append("  from: ").Append(from).Append("\n");
      sb.Append("  reply_to: ").Append(reply_to).Append("\n");
      sb.Append("  defaults: ").Append(defaults).Append("\n");
      sb.Append("  created_date: ").Append(created_date).Append("\n");
      sb.Append("  created_by_id: ").Append(created_by_id).Append("\n");
      sb.Append("  last_modified_date: ").Append(last_modified_date).Append("\n");
      sb.Append("  last_modified_by_id: ").Append(last_modified_by_id).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
